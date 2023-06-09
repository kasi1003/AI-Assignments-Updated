﻿using Microsoft.AspNetCore.Identity;
using PromotionsWebApp.Domain.Abstract;
using PromotionsWebApp.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PromotionsWebApp.Domain.Entities
{
    public class User:IdentityUser
    {
        public User() { }
        public User(TitleEnum title, string name, string surname, UserRoleEnum role, string email)
        {
            Title = title;
            FirstName = name;
            LastName = surname;
            Role = role;
            Email = email;
            EmailConfirmed = false;
            UserName = email;
            ProfileImage = GenerateAvatarImage();
            PasswordReset = true;
        }
        public User(TitleEnum title,string name,string surname,UserRoleEnum role,string email,int facId,int depId)
        {
            Title = title;
            FirstName = name;
            LastName = surname;
            Role = role;
            Email = email;
            EmailConfirmed = false;
            UserName = email;
            ProfileImage = GenerateAvatarImage();
            PasswordReset = true;
            FacultyId = facId;
            if (facId == 0)
            {
                FacultyId = null;
            }
            else
            {
                FacultyId = facId;
            }
            if (depId==0)
            {
                DepartmentId = null;
            }
            else
            {
                DepartmentId = depId;
            }
            
        }

        public TitleEnum Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfileImage { get; set; }
        public UserRoleEnum Role { get; set; }
        public int? FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public bool PasswordReset { get; set; }
        public bool isDeleted { get; set; }
        public override string ToString()
        {
            return Title.ToString() + ". " + FirstName + " " + LastName;
        }
        private byte[] GenerateAvatarImage()
        {
            //first, create a dummy bitmap just to get a graphics object  
            string text = FirstName.Substring(0, 1) + LastName.Substring(0, 1);
            using (var bitmap = new Bitmap(50, 50))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);
                    using (Brush b = new SolidBrush(ColorTranslator.FromHtml("#eeeeee")))
                    {

                        g.FillEllipse(b, 0, 0, 49, 49);
                    }

                    float emSize = 12;
                    g.DrawString(text, new Font(FontFamily.GenericSansSerif, emSize, FontStyle.Regular),
                        new SolidBrush(Color.Black), 10, 15);
                }

                using (var memStream = new System.IO.MemoryStream())
                {
                    bitmap.Save(memStream, System.Drawing.Imaging.ImageFormat.Png);
                    return memStream.ToArray();
                }
            }
        }
    }
}
