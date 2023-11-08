using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSalesMvc.Data;
using WebSalesMvc.Models;
using WebSalesMvc.Services;

namespace WebSalesMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly WebSalesMvcContext _context;
        private readonly SalesRecordService _salesRecordService;
        private readonly SellerService _sellerService;

        public SalesRecordsController(WebSalesMvcContext context, SalesRecordService salesRecordService, SellerService sellerService)
        {
            _context = context;
            _salesRecordService = salesRecordService;
            _sellerService = sellerService;

        }
        public async Task<IActionResult> Index()
        {
            var list = await _salesRecordService.FindAllAsync();

            if (list.Count == 0)
            {
                ViewBag.Message = "Sem registro de venda.";
                return View();
            }

            return View(list);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesRecord = await _context.SalesRecord
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesRecord == null)
            {
                return NotFound();
            }

            return View(salesRecord);
        }
        public async Task<IActionResult> Create()
        {
            var sellers = await _sellerService.FindAllAsync();
            var salesRecord = new SalesRecord();

            var viewModel = new SalesRecordsCreateViewModel
            {
                SalesRecord = salesRecord,
                Sellers = sellers
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SalesRecordsCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var salesRecord = viewModel.SalesRecord;
                await _salesRecordService.InsertAsync(salesRecord);
                return RedirectToAction(nameof(Index));
            }
                var sellers = await _sellerService.FindAllAsync();
                viewModel.Sellers = sellers; 

                return View(viewModel);
            
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesRecord = await _context.SalesRecord.FindAsync(id);
            if (salesRecord == null)
            {
                return NotFound();
            }
            return View(salesRecord);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Amount,Status,Seller")] SalesRecord salesRecord)
        {
            if (id != salesRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesRecordExists(salesRecord.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(salesRecord);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesRecord = await _context.SalesRecord
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesRecord == null)
            {
                return NotFound();
            }

            return View(salesRecord);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesRecord = await _context.SalesRecord.FindAsync(id);
            _context.SalesRecord.Remove(salesRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesRecordExists(int id)
        {
            return _context.SalesRecord.Any(e => e.Id == id);
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _salesRecordService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }

    }
}
