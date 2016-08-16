﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreManagement.Web.ViewModels.Category
{
    public class EditCategoryViewModel
    {
        [Required]
        public long Id { get; set; }
        [Required(ErrorMessage = "عنوان را وارد کنید.")]
        [StringLength(50, ErrorMessage = "عنوان نباید بیشتر از 50 کاراکتر باشد.")]
        [Remote("UniqueCategoryTitle",AdditionalFields ="Id",ErrorMessage ="یک گروه با این عنوان قبلا در سیستم ثبت شده است.")]
        public string Title { get; set; }
        [Required]
        public byte[] Version { get; set; }

    }
}