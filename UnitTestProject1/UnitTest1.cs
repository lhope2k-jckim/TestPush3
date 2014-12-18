using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestPush3Src.Popup popup = new TestPush3Src.Popup();
            popup.Pop();
            System.Windows.Forms.MessageBox.Show(popup.ToString());
            System.Windows.Forms.MessageBox.Show(popup.GetType().ToString());
            System.Windows.Forms.MessageBox.Show(popup.GetHashCode().ToString());
        }
    }
}
