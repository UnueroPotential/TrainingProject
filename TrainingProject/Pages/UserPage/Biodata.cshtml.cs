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
    public class BiodataModel : PageModel
    {
        private readonly TrainingContext _trainingContext;

        public BiodataModel(TrainingContext trainingContext)
        {
            _trainingContext = trainingContext;
        }
        [BindProperty]
        public BioDataTab BioDataTab { get; set; }
        public List<BioDataTab> BioDataTabList { get; set; }
        public async Task OnGetAsync(int? id)
        {
            if (id != null)
            {
                BioDataTab = await _trainingContext.BioDataTab.FirstOrDefaultAsync(s => s.Id == id);
                BioDataTabList = await _trainingContext.BioDataTab.ToListAsync();
            }
            else
            {
                BioDataTab = null;
            }
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var saveMethod = (dynamic)null;
            if (id != null)
            {
                saveMethod =  await _trainingContext.BioDataTab.FirstOrDefaultAsync(s => s.Id == id);
                if (saveMethod != null)
                {
                    saveMethod.Title = BioDataTab.Title;
                    saveMethod.Surname = BioDataTab.Surname;
                    saveMethod.FirstName = BioDataTab.FirstName;
                    saveMethod.OtherNames = BioDataTab.OtherNames;
                    saveMethod.Nationality = BioDataTab.Nationality;
                    saveMethod.State = BioDataTab.State;
                    saveMethod.LGA = BioDataTab.LGA;
                    saveMethod.Gender = BioDataTab.Gender;
                    saveMethod.MaritalStatus = BioDataTab.MaritalStatus;
                    saveMethod.Religion = BioDataTab.Religion;
                    saveMethod.PhoneNumber = BioDataTab.PhoneNumber;
                    saveMethod.Email = BioDataTab.Email;
                    saveMethod.DateofBirth = BioDataTab.DateofBirth;

                    _trainingContext.BioDataTab.Update(saveMethod);
                }
            }
            else
            {
                saveMethod = new BioDataTab
                {
                    Title = BioDataTab.Title,
                    Surname = BioDataTab.Surname,
                    FirstName = BioDataTab.FirstName,
                    OtherNames = BioDataTab.OtherNames,
                    Nationality = BioDataTab.Nationality,
                    State = BioDataTab.State,
                    LGA = BioDataTab.LGA,
                    Gender = BioDataTab.Gender,
                    MaritalStatus = BioDataTab.MaritalStatus,
                    Religion = BioDataTab.Religion,
                    PhoneNumber = BioDataTab.PhoneNumber,
                    Email = BioDataTab.Email,
                    DateofBirth = BioDataTab.DateofBirth
                };
                _trainingContext.BioDataTab.Add(saveMethod);
            }
     
            await _trainingContext.SaveChangesAsync();
            return Redirect("./BioDataList");
        }
        public async Task<IActionResult> OnPostJessicaAsync(int? id)
        {
            var saveMethod = (dynamic)null;
            if (id != null)
            {
                saveMethod = await _trainingContext.BioDataTab.FirstOrDefaultAsync(s => s.Id == id);
                if (saveMethod != null)
                {
                    saveMethod.Title = BioDataTab.Title;
                    saveMethod.Surname = BioDataTab.Surname;
                    saveMethod.FirstName = BioDataTab.FirstName;
                    saveMethod.OtherNames = BioDataTab.OtherNames;
                    saveMethod.Nationality = BioDataTab.Nationality;
                    saveMethod.State = BioDataTab.State;
                    saveMethod.LGA = BioDataTab.LGA;
                    saveMethod.Gender = BioDataTab.Gender;
                    saveMethod.MaritalStatus = BioDataTab.MaritalStatus;
                    saveMethod.Religion = BioDataTab.Religion;
                    saveMethod.PhoneNumber = BioDataTab.PhoneNumber;
                    saveMethod.Email = BioDataTab.Email;
                    saveMethod.DateofBirth = BioDataTab.DateofBirth;

                    _trainingContext.BioDataTab.Update(saveMethod);
                }
            }
            else
            {
                saveMethod = new BioDataTab
                {
                    Title = BioDataTab.Title,
                    Surname = BioDataTab.Surname,
                    FirstName = BioDataTab.FirstName,
                    OtherNames = BioDataTab.OtherNames,
                    Nationality = BioDataTab.Nationality,
                    State = BioDataTab.State,
                    LGA = BioDataTab.LGA,
                    Gender = BioDataTab.Gender,
                    MaritalStatus = BioDataTab.MaritalStatus,
                    Religion = BioDataTab.Religion,
                    PhoneNumber = BioDataTab.PhoneNumber,
                    Email = BioDataTab.Email,
                    DateofBirth = BioDataTab.DateofBirth
                };
                _trainingContext.BioDataTab.Add(saveMethod);
            }

            await _trainingContext.SaveChangesAsync();
            return Redirect("./BioDataList");
        }
    }
}
