using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System.Threading;

namespace MailRuCreator
{
    public partial class Mailru_Registrator : Form
    {
        public Mailru_Registrator()
        {
            InitializeComponent();
        }

        PhantomJSDriver driver;
        IJavaScriptExecutor js;
        UserData user;
        string defKapchaIMG = @".\Data\kapcha_def.jpg";
        string caption = "Mail.Ru BOT Info";

        private void Close_btn_Click(object sender, EventArgs e)
        {
            if (driver != null)
                driver.Quit();
            if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                new FileInfo(@".\Source\capchaIMG.jpg").Delete();
            Application.Exit();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            minimized.Visible = true;
        }

        private void Minimized_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            minimized.Visible = false;
        }

        private void UIClear()
        {
            login_box.Text = string.Empty;
            pass_box.Text = string.Empty;
            name_box.Text = string.Empty;
            surName_box.Text = string.Empty;
            kapcha_line.Text = string.Empty;
            kapcha_board.ImageLocation = defKapchaIMG;
        }


        private void Generate_btn_Click(object sender, EventArgs e)
        {
            UIClear();
            string infoText = "Please Wait While you Capcha will be Displayed";
            try
            {
                if (driver != null)
                    driver.Quit();

                MessageBox.Show(infoText, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                driver = new PhantomJSDriver();
                driver.Manage().Window.Maximize();
                js = driver;
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
                user = new UserData();
                user.GenerateUser();
                driver.Navigate().GoToUrl("https://account.mail.ru/signup?rf=auth.mail.ru&from=main");
                //First Name Input
                driver.FindElement(By.CssSelector("[name=\"firstname\"]")).SendKeys(user.Name);
                //Second Name Input
                driver.FindElement(By.CssSelector("[name=\"lastname\"]")).SendKeys(user.SurName);
                //date Day Input
                driver.FindElement(By.CssSelector(".b-date__day div")).Click();
                js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item day{user.Date.Day}')[0].click()");
                //driver.FindElement(By.CssSelector($".b-dropdown__list__item.day{user.Date.Day}")).Click();
                //date Month Input
                driver.FindElement(By.CssSelector(".b-date__month div")).Click();
                js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item__text')[{user.Date.Month + 30}].click()");
                //driver.FindElement(By.CssSelector($"[data-text=\"{user.GetMonthString(user.Date.Month)}\"]")).Click();
                //date Year Input
                driver.FindElement(By.CssSelector(".b-date__year div")).Click();
                js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item__text')[{user.YearIndex}].click()");
                //driver.FindElement(By.CssSelector($"[data-value=\"{user.Date.Year}\"]")).Click();
                //sex input
                if (!user.Sex)
                    driver.FindElement(By.CssSelector("[data-mnemo=\"sex-male\"]")).Click();
                else
                    driver.FindElement(By.CssSelector("[data-mnemo=\"sex-female\"]")).Click();

                //mail Address
                driver.FindElement(By.CssSelector(".b-email__name input")).SendKeys(user.MailAddress);
                driver.FindElement(By.CssSelector(".b-email__domain div")).Click();
                js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item__text')[{user.MailPrefixIndex}].click()");
                //driver.FindElement(By.CssSelector($"[data-value=\"{user.MailPrefix}\"]")).Click();
                //dont have number
                driver.FindElement(By.ClassName("js-signup-simple-link")).Click();
                //password Input
                driver.FindElement(By.CssSelector("[name=\"password\"]")).SendKeys(user.Password);
                driver.FindElement(By.CssSelector("[name=\"password_retry\"]")).SendKeys(user.Password);
                //register
                Thread.Sleep(500);
                //js.ExecuteScript("document.getElementsByClassName('btn_responsive-wide')[0].click()");
                ClickWhile(".b-form__controls button", 10);

                string imgPath = string.Empty;
                IWebElement img = WaitWhile(".b-captcha img", 15);
                if (img != null)
                {
                    imgPath = TakeScreenshotByLocationAndGivePath(img, driver);
                    kapcha_board.ImageLocation = imgPath;
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("Cant Find Kapcha IMG");
                    if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                        new FileInfo(@".\Source\capchaIMG.jpg").Delete();
                    driver.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                driver.Quit();
                if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                    new FileInfo(@".\Source\capchaIMG.jpg").Delete();
            }
        }

        private void ClickWhile(string cssSelector, int seconds)
        {
            IWebElement element = driver.FindElement(By.CssSelector(cssSelector));
            int s = DateTime.Now.Second + seconds;
            int m = DateTime.Now.Minute;
            if (s >= 60)
                s -= 60;
            do
            {
                element.Click();
                if (DateTime.Now.Second >= s || DateTime.Now.Minute > m)
                    break;
            } while (/*element.Displayed || */element.Enabled);
        }

        private IWebElement WaitWhile(string cssSelector, int seconds)
        {
            IWebElement el;
            do
            {
                el = driver.FindElement(By.CssSelector(cssSelector));
                System.Threading.Thread.Sleep(1000);
                seconds--;
                if (seconds == 0)
                    return null;
            } while (!el.Displayed);
            return el;
        }

        //Faster process on JS
        private void JavaScriptMacross()
        {
            //IJavaScriptExecutor js = driver;
            //START JavaSCRIPT
            //dont have email
            //js.ExecuteScript("document.getElementsByClassName('js-signup-simple-link')[0].click()");
            //input name
            //js.ExecuteScript($"document.getElementsByClassName('b-input_responsive')[1].value = \"{user.Name}\"");
            //input surname
            //js.ExecuteScript($"document.getElementsByClassName('b-input_responsive')[2].value = \"{user.SurName}\"");
            //data day
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__ctrl__text')[0].click()");
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item day{user.Date.Day}')[0].click()");
            //data month
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__ctrl__text')[1].click()");
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item__text')[{user.Date.Month + 30}].click()");
            //data year
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__ctrl__text')[2].click()");
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item__text')[{user.YearIndex}].click()");
            //sex
            //js.ExecuteScript($"document.getElementsByClassName('b-radiogroup__radio')[{Convert.ToInt16(user.Sex)}].click()");
            //mailadress
            //js.ExecuteScript($"document.getElementsByClassName('b-input_responsive')[4].value = \"{user.MailAdress}\"");
            //mail@.ru
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__ctrl')[3].click()");
            //js.ExecuteScript($"document.getElementsByClassName('b-dropdown__list__item__text')[162].click()");
            //entering password
            //js.ExecuteScript($"document.getElementsByClassName('b-input_plate')[0].value = \"{user.Password}\"");
            //entering password 2
            //js.ExecuteScript($"document.getElementsByClassName('b-input_popup')[5].value = \"{user.Password}\"");
            //register click
            //System.Threading.Thread.Sleep(1000);
            //js.ExecuteScript("document.getElementsByClassName('btn_responsive-wide')[0].click()");
            //END JavaSCRIPT
        }


        private string TakeScreenshotByLocationAndGivePath(IWebElement webImage, IWebDriver browser)
        {
            Point p = webImage.Location;
            Screenshot scr = ((ITakesScreenshot)browser).GetScreenshot();
            if (!Directory.Exists(@".\Source\"))
            {
                Directory.CreateDirectory(@".\Source\");
            }
            scr.SaveAsFile(@".\Source\cpt.bmp", ImageFormat.Bmp);
            using (Bitmap fullScreen = new Bitmap(@".\Source\cpt.bmp"))
            {
                Rectangle cutPart = new Rectangle(p.X, p.Y, webImage.Size.Width, webImage.Size.Height);
                Bitmap captchaBmp = fullScreen.Clone(cutPart, fullScreen.PixelFormat);
                captchaBmp.Save(@".\Source\capchaIMG.jpg", ImageFormat.Jpeg);
            }
            FileInfo file = new FileInfo(@".\Source\cpt.bmp");
            if (file.Exists)
                file.Delete();
            return $"{new FileInfo(@".\Source\capchaIMG.jpg").FullName}";
        }

        // visual design 
        //Drag Drop

        private bool mouseDown;
        private Point lastLocation;
        private void general_Drag_Drop_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void general_Drag_Drop_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void general_Drag_Drop_Panel_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;

        private void Generate_btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 71, 255);
            ((Button)sender).ForeColor = Color.FromArgb(248, 156, 14);
            ((Button)sender).FlatAppearance.BorderColor = Color.FromArgb(248, 156, 14);
        }

        private void Generate_btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 71, 133);
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).FlatAppearance.BorderColor = Color.White;
        }

        private void Mailru_Registrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
                driver.Quit();
        }

        private IWebElement FindWhile(string cssSelector, int seconds)
        {
            IWebElement element;
            do
            {
                if (seconds <= 0)
                    return null;
                element = driver.FindElement(By.CssSelector(cssSelector));
                Thread.Sleep(1000);
                seconds--;

            } while (element == null);
            return element;
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            //bool frameClosed = false;
            js.ExecuteScript("document.getElementsByClassName('b-input_captcha')[0].value = '';");
            string messageText = "Enter Capcha Code and press OK";
            if (string.IsNullOrEmpty(kapcha_line.Text) || string.IsNullOrWhiteSpace(kapcha_line.Text))
                MessageBox.Show(messageText, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    driver.FindElement(By.CssSelector(".b-captcha__code input")).SendKeys(kapcha_line.Text);
                    driver.FindElement(By.CssSelector(".b-form__control.b-form__control_main.b-form__control_stylish.b-form__control_responsive")).Click();
                    if (ErrorMessageEnabled(1))
                    {
                        MessageBox.Show("You are Entered Wrong Capcha try again and press OK", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        UIClear();
                        MessageBox.Show("Successfully registrated Mail.Ru Account Thank You For Using");
                        name_box.Text = user.Name;
                        surName_box.Text = user.SurName;
                        login_box.Text = user.FullMailAddress;
                        pass_box.Text = user.Password;
                        kapcha_board.ImageLocation = defKapchaIMG;
                        user.ClearUser();
                        Refresh();
                        driver.Quit();
                        if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                            new FileInfo(@".\Source\capchaIMG.jpg").Delete();
                    }
                    //int s = 5;
                    //do
                    //{
                    //    if (s == 0)
                    //        break;
                    //    try
                    //    {
                    //        js.ExecuteScript("document.getElementsByClassName('js-close-link')[0].click();");
                    //        frameClosed = true;
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        frameClosed = false;
                    //    }
                    //    Thread.Sleep(1000);
                    //    s--;
                    //} while (!frameClosed);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ErrorMessageEnabled(int seconds)
        {
            IWebElement element;
            do
            {
                if (seconds <= 0)
                    return false;
                try
                {
                    element = driver.FindElement(By.ClassName("b-captcha__error-msg"));
                }
                catch (Exception ex)
                {
                    element = null;
                }
                if (element == null)
                    return false;
                Thread.Sleep(1000);
                seconds--;

            } while (element.Text == string.Empty);
            return true;
        }

        //private bool IsSuccess(int seconds)
        //{
        //    IWebElement element = null;
        //    do
        //    {
        //        if (seconds <= 0)
        //            return false;
        //        try
        //        {
        //            element = driver.FindElement(By.Id("PH_user-email"));
        //            seconds--;
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        Thread.Sleep(1000);
        //        if (element.Text == user.FullMailAddress)
        //        {
        //            return true;
        //        }

        //    } while (seconds != 0);
        //    return true;
        //}

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            if (driver != null)
            {
                this.Refresh();
                if (!RefreshCapcha())
                    kapcha_board.ImageLocation = defKapchaIMG;
            }
        }


        private bool RefreshCapcha()
        {
            driver.FindElement(By.CssSelector(".js-captcha-reload.b-captcha__code__reload")).Click();
            if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                new FileInfo(@".\Source\capchaIMG.jpg").Delete();
            try
            {
                IWebElement img = WaitWhile(".b-captcha img", 10);
                string newImgPath = null;
                if (img != null)
                {
                    if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                        new FileInfo(@".\Source\capchaIMG.jpg").Delete();
                    Thread.Sleep(1500);
                    newImgPath = TakeScreenshotByLocationAndGivePath(img, driver);
                    kapcha_board.ImageLocation = newImgPath;
                    Refresh();
                    return true;
                }
                else
                {
                    MessageBox.Show("Cant Find Kapcha image", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (new FileInfo(@".\Source\capchaIMG.jpg").Exists)
                        new FileInfo(@".\Source\capchaIMG.jpg").Delete();
                    driver.Quit();
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (driver != null)
                    driver.Quit();
                return false;
                //MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refresh_btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label)
                ((Label)sender).BackColor = Color.FromArgb(248, 156, 14);
            else if (sender is PictureBox)
                ((PictureBox)sender).BackColor = Color.FromArgb(248, 156, 14);
        }

        private void Refresh_btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
                ((Label)sender).BackColor = Color.FromArgb(22, 71, 133);
            else if (sender is PictureBox)
                ((PictureBox)sender).BackColor = Color.FromArgb(22, 71, 133);
        }
        TextBox previous = null;
        private void Name_box_MouseClick(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender) != previous)
            {
                ((TextBox)sender).BackColor = Color.Silver;
                if (previous != null)
                    previous.BackColor = Color.White;
                previous = sender as TextBox;
            }
        }

        private void General_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            name_box.BackColor = Color.White;
            surName_box.BackColor = Color.White;
            login_box.BackColor = Color.White;
            pass_box.BackColor = Color.White;
            kapcha_line.BackColor = Color.White;
        }
    }
}
