﻿using FamilyManagement.Data;
using FamilyManagement.Data.Entities;
using FamilyManagement.Services.Interfaces;
using FamilyManagement.Services.Models.FamilyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = FamilyManagement.Data.Entities.Task;

namespace FamilyManagement.Services.FamilyManagementServices
{
    public class TaskService : ITaskService
    {
        private readonly FamilyManagementDbContext context;

        public TaskService(FamilyManagementDbContext context)
        {
            this.context = context;
        }
        
        public List<Task> GetAllTasks()
        {
            var tasks = context.Tasks
                .ToList();

            return tasks;
        }

        public Task CreateTask(TaskModel model)
        {
            var task = new Task
            {
                Title = model.Title,
                Description = model.Description,
                Status = model.Status,
                Deadline = model.Deadline,
                OwnerId = model.OwnerId,
                AssigneeId = model.AssigneeId,
                ToDoListId = model.ToDoListId
            };

             context.Tasks.Add(task);
             context.SaveChanges();

             return task;
            
        }
        
        
        public Task GetTaskById(int taskId)
        {
            var task = context.Tasks
                .Where(t => t.Id == taskId)
                .FirstOrDefault();

            return task;
        }

        public Task EditTask(TaskModel model, int taskId)
        {
            var task = GetTaskById(taskId);

            if (task == null)
            {
                return task;
            }

            task.Title = model.Title;
            task.Description = model.Description;
            task.Status = model.Status;
            task.Deadline = model.Deadline;
            task.OwnerId = model.OwnerId;
            task.AssigneeId = model.AssigneeId;
            task.ToDoListId = model.ToDoListId;

            context.Tasks.Update(task);
            context.SaveChanges();

            return task;
        }

        public Task DeleteTask(int taskId)
        {
            var task = GetTaskById(taskId);

            if (task == null)
            {
                return task;
            }

            context.Tasks.Remove(task);
            context.SaveChanges();

            return task;
        }
    }
}
