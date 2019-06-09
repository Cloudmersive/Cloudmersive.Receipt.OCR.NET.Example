using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cloudmersive.APIClient.NET.OCR.Api;
using Cloudmersive.APIClient.NET.OCR.Client;
using Cloudmersive.APIClient.NET.OCR.Model;
using Newtonsoft.Json;

namespace CloudmersiveReceiptOCR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "402380c4-b4f1-47bc-b5aa-cb76c73c1ed8");
            Configuration.Default.Timeout = 10000000;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(txtDirectory.Text))
            {
                ProcessFile(txtDirectory.Text);
            }

            //string filepath = txtDirectory.Text;
            //DirectoryInfo d = new DirectoryInfo(filepath);

            //foreach (var file in d.GetFiles("*"))
            //{
            //    ProcessFile(file.FullName);
            //}
        }

        private void ProcessFile(string fileName)
        {
            



            var apiInstance = new ImageOcrApi();
            using (var imageFile = new System.IO.FileStream(fileName, System.IO.FileMode.Open))
            {

                // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.
                var language = "ENG";  // string | Optional, language of the input document, default is English (ENG).  Possible values are ENG (English), ARA (Arabic), ZHO (Chinese - Simplified), ZHO-HANT (Chinese - Traditional), ASM (Assamese), AFR (Afrikaans), AMH (Amharic), AZE (Azerbaijani), AZE-CYRL (Azerbaijani - Cyrillic), BEL (Belarusian), BEN (Bengali), BOD (Tibetan), BOS (Bosnian), BUL (Bulgarian), CAT (Catalan; Valencian), CEB (Cebuano), CES (Czech), CHR (Cherokee), CYM (Welsh), DAN (Danish), DEU (German), DZO (Dzongkha), ELL (Greek), ENM (Archaic/Middle English), EPO (Esperanto), EST (Estonian), EUS (Basque), FAS (Persian), FIN (Finnish), FRA (French), FRK (Frankish), FRM (Middle-French), GLE (Irish), GLG (Galician), GRC (Ancient Greek), HAT (Hatian), HEB (Hebrew), HIN (Hindi), HRV (Croatian), HUN (Hungarian), IKU (Inuktitut), IND (Indonesian), ISL (Icelandic), ITA (Italian), ITA-OLD (Old - Italian), JAV (Javanese), JPN (Japanese), KAN (Kannada), KAT (Georgian), KAT-OLD (Old-Georgian), KAZ (Kazakh), KHM (Central Khmer), KIR (Kirghiz), KOR (Korean), KUR (Kurdish), LAO (Lao), LAT (Latin), LAV (Latvian), LIT (Lithuanian), MAL (Malayalam), MAR (Marathi), MKD (Macedonian), MLT (Maltese), MSA (Malay), MYA (Burmese), NEP (Nepali), NLD (Dutch), NOR (Norwegian), ORI (Oriya), PAN (Panjabi), POL (Polish), POR (Portuguese), PUS (Pushto), RON (Romanian), RUS (Russian), SAN (Sanskrit), SIN (Sinhala), SLK (Slovak), SLV (Slovenian), SPA (Spanish), SPA-OLD (Old Spanish), SQI (Albanian), SRP (Serbian), SRP-LAT (Latin Serbian), SWA (Swahili), SWE (Swedish), SYR (Syriac), TAM (Tamil), TEL (Telugu), TGK (Tajik), TGL (Tagalog), THA (Thai), TIR (Tigrinya), TUR (Turkish), UIG (Uighur), UKR (Ukrainian), URD (Urdu), UZB (Uzbek), UZB-CYR (Cyrillic Uzbek), VIE (Vietnamese), YID (Yiddish) (optional) 

                try
                {
                    // Convert a photo of a document into text
                    var result = apiInstance.ImageOcrPhotoWordsWithLocation(imageFile, language);
                    Debug.WriteLine( JsonConvert.SerializeObject( result ));
                }
                catch (Exception e)
                {
                    Debug.Print("Exception when calling ImageOcrApi.ImageOcrPhotoToText: " + e.Message);
                }
            }
        }
    }
}
