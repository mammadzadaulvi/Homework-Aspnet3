﻿using front_to_back.Models;

namespace front_to_back.ViewModels.Contact
{
    public class ContactIndexViewModel
    {
        public ContactIntroComponent ContactIntroComponent { get; set; }
        public ContactCreateComponent ContactCreateComponent { get; set; }
        public List<ContactMediaComponent> ContactMediaComponents { get; set; }

    }
}
