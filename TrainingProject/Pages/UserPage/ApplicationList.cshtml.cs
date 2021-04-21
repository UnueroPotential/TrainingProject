using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainingProjectClass;

namespace TrainingProject.Pages.UserPage
{
    public class ApplicationListModel : PageModel
    {
        private readonly TrainingContext _trainingContext;

        public ApplicationListModel(TrainingContext trainingContext)
        {
            _trainingContext = trainingContext;
        }
        public void OnGet()
        {
        }
    }
}
