﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SocialMediaManager : ISocialMediaService
	{
		ISocialMedia _socialMedia;

		public SocialMediaManager(ISocialMedia socialMedia)
		{
			_socialMedia = socialMedia;
		}

		public void Delete(SocialMedia t)
		{
			_socialMedia.Delete(t);
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public SocialMedia GetById(int id)
		{
		 return	_socialMedia.GetById(id);
		}

		public List<SocialMedia> GetListAll()
		{
			return _socialMedia.GetListAll();
		}

		public void Insert(SocialMedia t)
		{
			_socialMedia.Insert(t);
		}

		public void Update(SocialMedia t)
		{
			_socialMedia.Update(t);
		}
	}
}
