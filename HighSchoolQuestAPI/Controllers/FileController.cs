using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolQuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        public FileController()
        {
        }

        [HttpPost]
        public async Task<IActionResult> UploadExcelFile(IFormFile file)
        {
            if (file == null || !file.FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("Invalid file format. Please upload an Excel file.");
            }

            string fileName = Path.GetFileName(file.FileName);
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "upload", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(filePath);
        }

        [HttpGet]
        public async Task<IActionResult> GetFile(string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "upload", fileName);
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }
            byte[] fileContent = System.IO.File.ReadAllBytes(filePath);
            return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
    }
}
