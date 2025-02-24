#region

using Aspose.Pdf;
using Document = Aspose.Pdf.Document;

#endregion

namespace Libraries.UralMathLib;

public static partial class UralMathLib
{
    public class UralLaTeX
    {
        public str64 Tex;
        public readonly str32? TexDir;


        public UralLaTeX(string texcode)
        {
            this.Tex = new str64(texcode);
        }

        public UralLaTeX(string texcode, string TexFileDir)
        {
            this.Tex = new str64(texcode);
            this.TexDir = new str32(TexFileDir);
        }

        public UralLaTeX(str16 texcode)
        {
            this.Tex = new str64(texcode);
        }

        public UralLaTeX(str16 texcode, str16 TexFileDir)
        {
            this.Tex = new str64(texcode);
            this.TexDir = new str32(TexFileDir);
        }

        public UralLaTeX(str32 texcode)
        {
            this.Tex = new str64(texcode);
        }

        public UralLaTeX(str32 texcode, str32 TexFileDir)
        {
            this.Tex = new str64(texcode);
            this.TexDir = new str32(TexFileDir);
        }

        public UralLaTeX(str64 texcode)
        {
            this.Tex = new str64(texcode);
        }

        public UralLaTeX(str64 texcode, str64 TexFileDir)
        {
            this.Tex = new str64(texcode);
            this.TexDir = new str32(TexFileDir);
        }


        public RCI CreateFile(string? TexFileDir = null)
        {
            using (FileStream fs = File.Create(TexFileDir))
            {
                switch (this.TexDir?.value)
                {
                    case null when TexFileDir is null :
                        return new RCI(false);
                    case null :
                        File.AppendAllText(TexFileDir, this.Tex + Environment.NewLine);
                        goto End;
                    default :
                        File.AppendAllText(this.TexDir.value, this.Tex + Environment.NewLine);
                        goto End;
                }
            }

            End:
            return new RCI(true);
        }

        public RCI CreateFile(str16? TexFileDir = null)
        {
            using (FileStream fs = File.Create(TexFileDir.value))
            {
                switch (this.TexDir?.value)
                {
                    case null when TexFileDir?.value is null :
                        return new RCI(false);
                    case null :
                        File.AppendAllText(TexFileDir.value, this.Tex + Environment.NewLine);
                        goto End;
                    default :
                        File.AppendAllText(this.TexDir.value, this.Tex + Environment.NewLine);
                        goto End;
                }
            }

            End:
            return new RCI(true);
        }

        public RCI CreateFile(str32? TexFileDir = null)
        {
            using (FileStream fs = File.Create(TexFileDir.value))
            {
                switch (this.TexDir?.value)
                {
                    case null when TexFileDir?.value is null :
                        return new RCI(false);
                    case null :
                        File.AppendAllText(TexFileDir.value, this.Tex + Environment.NewLine);
                        goto End;
                    default :
                        File.AppendAllText(this.TexDir.value, this.Tex + Environment.NewLine);
                        goto End;
                }
            }

            End:
            return new RCI(true);
        }

        public RCI CreateFile(str64? TexFileDir = null)
        {
            using (FileStream fs = File.Create(TexFileDir.value))
            {
                switch (this.TexDir?.value)
                {
                    case null when TexFileDir?.value is null :
                        return new RCI(false);
                    case null :
                        File.AppendAllText(TexFileDir.value, this.Tex + Environment.NewLine);
                        goto End;
                    default :
                        File.AppendAllText(this.TexDir.value, this.Tex + Environment.NewLine);
                        goto End;
                }
            }

            End:
            return new RCI(true);
        }

        public RCI DeleteFile(string? TexFileDir = null)
        {
            switch (this.TexDir?.value)
            {
                case null when TexFileDir is null : { goto End; }
                case null :
                {
                    if (File.Exists(TexFileDir))
                    {
                        File.Delete(TexFileDir);
                        return new RCI(true);
                    }

                    goto End;
                }
                default :
                {
                    if (File.Exists(this.TexDir.value))
                    {
                        File.Delete(this.TexDir.value);
                        return new RCI(true);
                    }

                    goto End;
                }
            }


            End:
            return new RCI(false);
        }

        public void LatexToPdf(string TexFileDir, string PdfFileDir)
        {
            // Load the TEX document
            using (Document pdfDocument = new Document(TexFileDir, new TeXLoadOptions()))
            {
                // Save PDF file
                pdfDocument.Save(PdfFileDir);
            }
        }

        public void LatexToDoc(string TexFileDir, string DocFileDir)
        {
            // Load the TEX document
            Document pdfDocument = new Document(TexFileDir, new TeXLoadOptions());
            // Save DOC/DOCX file
            pdfDocument.Save(DocFileDir, SaveFormat.DocX);
        }

        public void ConvertTEXtoHTML(string TexFileDir, string HtmlFileDir)
        {
            // Load the TEX document
            Document document = new Document(TexFileDir, new TeXLoadOptions());
            //Save HTML file
            document.Save(HtmlFileDir, SaveFormat.Html);
        }
    }
}