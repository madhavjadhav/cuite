﻿using System.IO;
using Aut.WinForms.ControlsTest.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aut.WinForms.ControlsTest
{
    [CodedUITest]
#if DEBUG
    [DeploymentItem(@"..\..\..\Aut.WinForms.Controls\bin\Debug")]
#else
    [DeploymentItem(@"..\..\..\Aut.WinForms.Controls\bin\Release")]
#endif
    public class ControlTests
    {
        private const string ApplicationFileName = "Aut.WinForms.Controls.exe";

        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            string applicationFilePath = Path.Combine(TestContext.DeploymentDirectory, ApplicationFileName);
            ApplicationUnderTest.Launch(applicationFilePath);

            mainScreen = new MainScreen();
        }

        [TestMethod]
        public void Button()
        {
            // Assert
            Assert.IsTrue(mainScreen.Button.Exists);
        }

        [TestMethod]
        public void CheckBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.CheckBox.Exists);
        }

        [Ignore]
        [TestMethod]
        public void ComboBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ComboBox.Exists);
        }

        [TestMethod]
        public void DateTimePicker()
        {
            // Assert
            Assert.IsTrue(mainScreen.DateTimePicker.Exists);
        }

        [TestMethod]
        public void GroupBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.GroupBox.Exists);
        }

        [TestMethod]
        public void Label()
        {
            // Assert
            Assert.IsTrue(mainScreen.Label.Exists);
        }

        [TestMethod]
        public void LinkLabel()
        {
            // Assert
            Assert.IsTrue(mainScreen.LinkLabel.Exists);
        }

        [Ignore]
        [TestMethod]
        public void ListBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListBox.Exists);
        }

        [Ignore]
        [TestMethod]
        public void ListView()
        {
            // Assert
            Assert.IsTrue(mainScreen.ListView.Exists);
        }

        [Ignore]
        [TestMethod]
        public void MaskedTextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.MaskedTextBox.Exists);
        }

        [Ignore]
        [TestMethod]
        public void MonthCalendar()
        {
            // Assert
            Assert.IsTrue(mainScreen.MonthCalendar.Exists);
        }

        [Ignore]
        [TestMethod]
        public void NumericUpDown()
        {
            // Assert
            Assert.IsTrue(mainScreen.NumericUpDown.Exists);
        }

        [Ignore]
        [TestMethod]
        public void PictureBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.PictureBox.Exists);
        }

        [Ignore]
        [TestMethod]
        public void ProgressBar()
        {
            // Assert
            Assert.IsTrue(mainScreen.ProgressBar.Exists);
        }

        [TestMethod]
        public void RadioButton()
        {
            // Assert
            Assert.IsTrue(mainScreen.RadioButton.Exists);
        }

        [Ignore]
        [TestMethod]
        public void RichTextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.RichTextBox.Exists);
        }

        [Ignore]
        [TestMethod]
        public void TabControl()
        {
            // Assert
            Assert.IsTrue(mainScreen.TabControl.Exists);
        }

        [Ignore]
        [TestMethod]
        public void TextBox()
        {
            // Assert
            Assert.IsTrue(mainScreen.TextBox.Exists);
        }

        [Ignore]
        [TestMethod]
        public void TreeView()
        {
            // Assert
            Assert.IsTrue(mainScreen.TreeView.Exists);
        }

        [Ignore]
        [TestMethod]
        public void WebBrowser()
        {
            // Assert
            Assert.IsTrue(mainScreen.WebBrowser.Exists);
        }
    }
}