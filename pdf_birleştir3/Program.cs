using System.Reflection.PortableExecutable;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
namespace pdf_birleştir3
{
	public class brl
	{
		public static byte[] Combine(IEnumerable<byte[]> pdfs)
		{
			using (var writerMemoryStream = new MemoryStream())
			{
				using (var writer = new PdfWriter(writerMemoryStream))
				{
					using (var mergedDocument = new PdfDocument(writer))
					{
						var merger = new PdfMerger(mergedDocument);

						foreach (var pdfBytes in pdfs)
						{
							using (var copyFromMemoryStream = new MemoryStream(pdfBytes))
							{
								using (var reader = new PdfReader(copyFromMemoryStream))
								{
									using (var copyFromDocument = new PdfDocument(reader))
									{
										merger.Merge(copyFromDocument, 1, copyFromDocument.GetNumberOfPages());
									}
								}
							}
						}
					}
				}

				return writerMemoryStream.ToArray();
			}
		}
	}



	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}