﻿using MoneyFox.Shared.Interfaces;
using MoneyFox.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MoneyFox.Shared.Tests.Mocks
{
    public class CategoryDataAccessMock : IDataAccess<Category>
    {
        public List<Category> CategoryTestList = new List<Category>();

        public void SaveItem(Category itemToSave)
        {
            CategoryTestList.Add(itemToSave);
        }

        public void DeleteItem(Category item)
        {
            if (CategoryTestList.Contains(item))
            {
                CategoryTestList.Remove(item);
            }
        }

        public List<Category> LoadList(Expression<Func<Category, bool>> filter = null) => CategoryTestList;
    }
}