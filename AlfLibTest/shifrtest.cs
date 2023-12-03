using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlfLib;

namespace AlfLibTest
{
    [TestClass]
    public class shifrtest
    {
        [TestMethod]
        public void Shifr_Sifrovanie1()
        {
            string text = "от улыбки каждый день светлей";
            string key = "мышь";
            string fl = "ынлззьгечыяазеьбъчйюсндбц";
            shifr shifr = new shifr();
            string result = shifr.Sifrovanie(key,text);
            Assert.AreEqual(fl, result);
        }

        [TestMethod]
        public void Shifr_DESifrovanie1()
        {
            string text = "ынлззьгечыяазеьбъчйюсндбц";
            string key = "мышь";
            string fl = "отулыбкикаждыйденьсветлей";
            shifr shifr = new shifr();
            string result = shifr.DeSifrovanie(key, text);
            Assert.AreEqual(fl, result);
        }

        [TestMethod]
        public void Shifr_Sifrovanie2()
        {
            string text = "Бобик сидел на скамейке и ел бутер брод";
            string key = "мышь";
            string fl = "нйщечмбасжёьюёшисегбхадэанэмнлжа";
            shifr shifr = new shifr();
            string result = shifr.Sifrovanie(key, text);
            Assert.AreEqual(fl, result);
        }

        [TestMethod]
        public void Shifr_DESifrovanie2()
        {
            string text = "нйщечмбасжёьюёшисегбхадэанэмнлжа";
            string key = "мышь";
            string fl = "бобиксиделнаскамейкеиелбутерброд";
            shifr shifr = new shifr();
            string result = shifr.DeSifrovanie(key, text);
            Assert.AreEqual(fl, result);
        }

        [TestMethod]
        public void Shifr_Sifrovanie3()
        {
            string text = "от улыбки каждый день светлей";
            string key = "клей";
            string fl = "щюшхёмптхллнёхиошзцлпюроф";
            shifr shifr = new shifr();
            string result = shifr.Sifrovanie(key, text);
            Assert.AreEqual(fl, result);
        }

        [TestMethod]
        public void Shifr_DESifrovanie3()
        {
            string text = "щюшхёмптхллнёхиошзцлпюроф";
            string key = "клей";
            string fl = "отулыбкикаждыйденьсветлей";
            shifr shifr = new shifr();
            string result = shifr.DeSifrovanie(key, text);
            Assert.AreEqual(fl, result);
        }
    }
}

