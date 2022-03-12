using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ZodiacSignMatch
    {
        private static Dictionary<eZodiacSign, string> sr_ImagesUrl;

        public eZodiacSign Sign { get; private set; }

        public string PictureUrl { get; private set; }

        public string MatchSignName { get; private set; }

        public ZodiacSignMatch BestMatchedWithSign
        {
            get
            {
                eZodiacSign matchedSign = pickMatchedSign();
                MatchSignName = Enum.GetName(typeof(eZodiacSign), matchedSign);
                return new ZodiacSignMatch(matchedSign);
            }
        }

        public enum eMonth
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        public enum eZodiacSign
        {
            Aquarius = 0,
            Pisces,
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
        }

        static ZodiacSignMatch()
        {
            initZodiacSignsImagesUrlList();
        }

        public ZodiacSignMatch(string i_Birthday)
        {
            initUserZodiacSign(i_Birthday);
            PictureUrl = sr_ImagesUrl[Sign];
        }

        private ZodiacSignMatch(eZodiacSign i_Sign)
        {
            Sign = i_Sign;
            PictureUrl = sr_ImagesUrl[Sign];
        }

        private static void initZodiacSignsImagesUrlList()
        {
            sr_ImagesUrl = new Dictionary<eZodiacSign, string>();

            sr_ImagesUrl[eZodiacSign.Aquarius] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/4b74ed238220/sub-buzz-7902-1598941285-9.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Pisces] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/00741fdf07c6/sub-buzz-8044-1598942757-6.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Aries] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/e8c474b0cad9/sub-buzz-7999-1598940815-2.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Taurus] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/00741fdf07c6/sub-buzz-8026-1598942395-15.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Gemini] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/4e214feff5ce/sub-buzz-7995-1598941278-3.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Cancer] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/e8c474b0cad9/sub-buzz-8048-1598942676-3.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Leo] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/e8c474b0cad9/sub-buzz-8004-1598940877-15.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Virgo] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/4b74ed238220/sub-buzz-7938-1598942442-1.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Libra] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/5811cc3bf67c/sub-buzz-7889-1598941236-3.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Scorpio] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/9803fc6962aa/sub-buzz-7942-1598942700-14.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Sagittarius] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/0b98b98804e1/sub-buzz-7991-1598941060-27.png?output-format=auto&output-quality=auto";
            sr_ImagesUrl[eZodiacSign.Capricorn] = "https://img.buzzfeed.com/buzzfeed-static/static/2020-09/1/6/asset/0b98b98804e1/sub-buzz-8039-1598942478-14.png?output-format=auto&output-quality=auto";
        }

        private void initUserZodiacSign(string i_Birthday)
        {
            string[] dateFormat = i_Birthday.Split('/');
            eMonth month = (eMonth)(int.Parse(dateFormat[0]));
            int day = int.Parse(dateFormat[1]);

            switch (month)
            {
                case eMonth.January:
                    Sign = day >= 21 ? eZodiacSign.Aquarius : eZodiacSign.Capricorn;
                    break;
                case eMonth.February:
                    Sign = day >= 19 ? eZodiacSign.Pisces : eZodiacSign.Capricorn;
                    break;
                case eMonth.March:
                    Sign = day >= 21 ? eZodiacSign.Aries : eZodiacSign.Pisces;
                    break;
                case eMonth.April:
                    Sign = day >= 20 ? eZodiacSign.Taurus : eZodiacSign.Aries;
                    break;
                case eMonth.May:
                    Sign = day >= 21 ? eZodiacSign.Gemini : eZodiacSign.Taurus;
                    break;
                case eMonth.June:
                    Sign = day >= 21 ? eZodiacSign.Cancer : eZodiacSign.Gemini;
                    break;
                case eMonth.July:
                    Sign = day >= 23 ? eZodiacSign.Leo : eZodiacSign.Cancer;
                    break;
                case eMonth.August:
                    Sign = day >= 23 ? eZodiacSign.Virgo : eZodiacSign.Leo;
                    break;
                case eMonth.September:
                    Sign = day >= 23 ? eZodiacSign.Libra : eZodiacSign.Virgo;
                    break;
                case eMonth.October:
                    Sign = day >= 23 ? eZodiacSign.Scorpio : eZodiacSign.Libra;
                    break;
                case eMonth.November:
                    Sign = day >= 22 ? eZodiacSign.Sagittarius : eZodiacSign.Scorpio;
                    break;
                case eMonth.December:
                    Sign = day >= 22 ? eZodiacSign.Capricorn : eZodiacSign.Sagittarius;
                    break;
            }
        }

        private eZodiacSign pickMatchedSign()
        {
            Random random = new Random();
            int fateSelection = random.Next(0, Enum.GetNames(typeof(eZodiacSign)).Length);
            return (eZodiacSign)fateSelection;
        }
    }
}
