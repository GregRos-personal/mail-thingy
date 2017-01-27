using System.Web.Mvc;
using MailThingy.Models;

namespace MailThingy.Controllers {
	public class MainController : Controller {
		// GET: Main
		[HttpGet]
		public ActionResult Index() {
			return View();
		}

		[HttpGet]
		public ActionResult Connection() {
			return View();
		}

		private static OperationResult FailureResult() {
			return new OperationResult() {
				Kind = ResultKind.Failure,
				Message = "There is a problem with one of the inputs"
			};
		}

		private static OperationResult SuccessResult() {
			return new OperationResult() {
				Kind = ResultKind.Success,
				Message = "The action was sent successfuly"
			};
		}

		//NOTE: Inputs are santitized by the framework so we don't need to worry about XSS.
		[HttpPost]
		public ActionResult Connection(Connection connection) {
			if (connection == null || connection.IsValid) {
				ViewBag.Message = FailureResult();
			}
			else {
				ViewBag.Message = SuccessResult();
			}
			return View();
		}

		[HttpGet]
		public ActionResult Deposit() {
			return View();
		}



		[HttpPost]
		public ActionResult Deposit(Deposit deposit) {
			if (deposit == null || !deposit.IsValid) {
				ViewBag.Message = FailureResult();
			}
			else {
				ViewBag.Message = SuccessResult();
			}
			return View();
		}
	}
}