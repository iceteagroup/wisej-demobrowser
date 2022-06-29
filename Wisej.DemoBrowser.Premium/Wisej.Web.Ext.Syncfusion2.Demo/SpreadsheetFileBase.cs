using System;
using System.IO;
using System.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo
{
    public class SpreadsheetFileBase : HttpPostedFileBase
    {
        private Stream _stream;

        private string _contentType;

        private string _fileName;

        public override int ContentLength => (int)_stream.Length;

        public override string FileName => _fileName;

        public override Stream InputStream => _stream;

        public override string ContentType => _contentType;

        public SpreadsheetFileBase(Stream stream, string fileName)
        {
            this._stream = stream;
            this._fileName = fileName;

            var extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case ".xlsx":
                    this._contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;

                case ".xls":
                    this._contentType = "application/vnd.ms-excel";
                    break;

                case ".csv":
                    this._contentType = "text/csv";
                    break;

                case ".pdf":
                    this._contentType = "application/pdf";
                    break;

                default:
                    this._contentType = "application/octet-stream";
                    break;
            }
        }
    }
}