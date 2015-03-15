using System.Web.Mvc;

using System.Data.Entity; //The Reference for Async Methods

using A3_EF6_Ext.Models;
using System.Threading.Tasks;

namespace A3_EF6_Ext.Controllers
{
    public class EmployeeInfoController : Controller
    {
        EXTEDMX ctx;
        public EmployeeInfoController()
        {
            ctx = new EXTEDMX(); 
        }

        // GET: EmployeeInfo
        public async Task<ActionResult> Index()
        {
            ctx.Database.Log = l => LogInfo(l);
            var Emps = await ctx.Employees.ToListAsync();
            return View(Emps);
        }

        public ActionResult Create()
        {
            return View(new EmployeeInfo());
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmployeeInfo Emp)
        {

            if (ModelState.IsValid)
            {
                ctx.Database.Log = l => LogInfo(l); //Log
                ctx.Employees.Add(Emp);
                await ctx.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(Emp);
            }
        }

        /// <summary>
        /// Method for Logging Infrastructure
        /// </summary>
        /// <param name="logmessage"></param>
        private void LogInfo(string logmessage)
        {
            string FilePath = HttpContext.Server.MapPath("~/LoggerRepository/LoggerFile.txt");
            System.IO.File.AppendAllText(FilePath, logmessage);
        }
    }
}