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
    public class BioDataListModel : PageModel
    {
        private readonly TrainingContext _trainingContext;

        public BioDataListModel(TrainingContext trainingContext)
        {
            _trainingContext = trainingContext;
        }
        [BindProperty]
        public BioDataTab BioDataTab { get; set; }
        public IList<BioDataTab> BioDataTabList { get; set; }
        public async Task OnGetAsync()
        {
            BioDataTabList = await _trainingContext.BioDataTab.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var saveMethod = (dynamic)null;
            if (id != null)
            {
                saveMethod = await _trainingContext.BioDataTab.FirstOrDefaultAsync(s => s.Id == id);
                if (saveMethod != null)
                {
                    _trainingContext.BioDataTab.Remove(saveMethod);
                }
            }
            await _trainingContext.SaveChangesAsync();
            return Redirect("./BioDataList");
        }
    }
}
