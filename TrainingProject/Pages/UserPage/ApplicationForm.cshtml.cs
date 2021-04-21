using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainingProjectClass;
using TrainingProjectClass.ProjectModels;
using Microsoft.EntityFrameworkCore;

namespace TrainingProject.Pages.UserPage
{
    public class ApplicationFormModel : PageModel
    {
        private readonly TrainingContext _trainingContext;

        public ApplicationFormModel(TrainingContext trainingContext)
        {
            _trainingContext = trainingContext;
        }
        [BindProperty]
        public ApplicationTab ApplicationTab { get; set; }
        public async Task OnGetAsync(int? id)
        {
            if (id != null)
            {
                ApplicationTab = await _trainingContext.ApplicationTab.FirstOrDefaultAsync(s => s.Id == id);
            }
            else
            {
                ApplicationTab = null;
            }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var saveMethod  = new ApplicationTab
            {
                ApplicantName = ApplicationTab.ApplicantName,
                ApplicantPhoneNumber = ApplicationTab.ApplicantPhoneNumber,
                ApplicantEmail = ApplicationTab.ApplicantEmail,
                ApplicantAddress = ApplicationTab.ApplicantAddress,
                PositionApply = ApplicationTab.PositionApply,
                DateApplied = DateTime.Now,
                ApplicationStatus = false,
            };
            _trainingContext.ApplicationTab.Add(saveMethod);
           
            await _trainingContext.SaveChangesAsync();
            return Redirect("./ApplicationList");
        }
    }
}
