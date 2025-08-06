using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyNavSolutions.Handler
{
    public class NavegacionSeguraHandler : ILifeSpanHandler
    {

       

        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame,
        string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition,
        bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo,
        IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;

          
            if (!EsUrlSegura(targetUrl))
            {
                MessageBox.Show("Enlace inválido o potencialmente peligroso bloqueado.", "Seguridad de navegación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; 
            }

         
            string[] permitidos = { "https://www.perplexity.ai" };
            bool esInterno = permitidos.Any(d => targetUrl.Contains(d));

            if (!esInterno)
            {
                MessageBox.Show($"Acceso bloqueado a: {targetUrl}", "Navegación externa bloqueada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; 
            }

            return false; 
        }

        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
        public bool DoClose(IWebBrowser browserControl, IBrowser browser) => false;
        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }


        private bool EsUrlSegura(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uriValidada)) 
                return false;

            string esquema = uriValidada.Scheme;
            if (esquema != Uri.UriSchemeHttp && esquema != Uri.UriSchemeHttps)
                return false;

            if (url.IndexOf("javascript:", StringComparison.OrdinalIgnoreCase) >= 0 ||
                url.IndexOf("<script>", StringComparison.OrdinalIgnoreCase) >= 0 ||
                url.IndexOf("onerror=", StringComparison.OrdinalIgnoreCase) >= 0 ||
                url.IndexOf("onload=", StringComparison.OrdinalIgnoreCase) >= 0)
                return false;
            

            return true;
        }
    }


    }

