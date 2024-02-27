using Microsoft.AspNetCore.Components;
using WebbLabb3.UI.Models;

namespace WebbLabb3.UI.Pages
{
    public partial class Index
    {
        //About CRUD
        private void OnAboutSelected(ChangeEventArgs about)
        {

            var selectedAboutIdStr = about.Value.ToString();
            if (int.TryParse(selectedAboutIdStr, out int selectedAboutId))
            {
                _about = AboutList.FirstOrDefault(a => a.Id == selectedAboutId);
                if (_about != null)
                {
                    Console.WriteLine($"Selected skill ID: {_about.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }

        }

        //C
        private async Task PostAboutTask()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/About", _about);
                if (response.IsSuccessStatusCode)
                {
                    _about = new About();
                    AboutList = await httpClient.GetFromJsonAsync<List<About>>("https://webblabb3api.azurewebsites.net/Abouts");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task PutAboutTask()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/About/{_about.Id}", _about);
                if (response.IsSuccessStatusCode)
                {
                    _about = new About();
                    AboutList = await httpClient.GetFromJsonAsync<List<About>>("https://webblabb3api.azurewebsites.net/Abouts");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteAboutTask()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/About/{_about.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _about = new About();
                    AboutList = await httpClient.GetFromJsonAsync<List<About>>("https://webblabb3api.azurewebsites.net/Abouts");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Skill CRUD
        private async Task OnSkillSelected(ChangeEventArgs skill)
        {
            var selectedSkillIdStr = skill.Value.ToString();
            if (int.TryParse(selectedSkillIdStr, out int selectedSkillId))
            {
                _skills = SkillsList.FirstOrDefault(a => a.Id == selectedSkillId);
                if (_skills != null)
                {
                    Console.WriteLine($"Selected skill ID: {_skills.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }
        }

        //C
        private async Task CreateSkill()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/skill", _skills);
                if (response.IsSuccessStatusCode)
                {
                    _skills = new Skills();
                    SkillsList = await httpClient.GetFromJsonAsync<List<Skills>>("https://webblabb3api.azurewebsites.net/skills");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task UpdateSkill()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/skill/{_skills.Id}", _skills);
                if (response.IsSuccessStatusCode)
                {
                    _skills = new Skills();
                    SkillsList = await httpClient.GetFromJsonAsync<List<Skills>>("https://webblabb3api.azurewebsites.net/skills");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteSelectedSkill()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/skill/{_skills.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _skills = new Skills();
                    SkillsList = await httpClient.GetFromJsonAsync<List<Skills>>("https://webblabb3api.azurewebsites.net/skills");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Skill CRUD
        private async Task OnProjectSelected(ChangeEventArgs project)
        {
            var selectedProject = project.Value.ToString();
            if (int.TryParse(selectedProject, out int selectedProjectId))
            {
                _projects = ProjectList.FirstOrDefault(a => a.Id == selectedProjectId);
                if (_projects != null)
                {
                    Console.WriteLine($"Selected skill ID: {_projects.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }
        }

        //C
        private async Task PostProject()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/project", _projects);
                if (response.IsSuccessStatusCode)
                {
                    _projects = new Projects();
                    ProjectList = await httpClient.GetFromJsonAsync<List<Projects>>("https://webblabb3api.azurewebsites.net/projects");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task PutProject()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/project/{_projects.Id}", _projects);
                if (response.IsSuccessStatusCode)
                {
                    _projects = new Projects();
                    ProjectList = await httpClient.GetFromJsonAsync<List<Projects>>("https://webblabb3api.azurewebsites.net/projects");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteProject()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/project/{_projects.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _projects = new Projects();
                    ProjectList = await httpClient.GetFromJsonAsync<List<Projects>>("https://webblabb3api.azurewebsites.net/projects");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Education CRUD
        private async Task OnEducationSelected(ChangeEventArgs education)
        {
            var selectedEducation = education.Value.ToString();
            if (int.TryParse(selectedEducation, out int selectedEducationId))
            {
                _education = EducationList.FirstOrDefault(a => a.Id == selectedEducationId);
                if (_projects != null)
                {
                    Console.WriteLine($"Selected skill ID: {_education.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }
        }

        //C
        private async Task PostEducation()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/education", _education);
                if (response.IsSuccessStatusCode)
                {
                    _education = new Education();
                    EducationList = await httpClient.GetFromJsonAsync<List<Education>>("https://webblabb3api.azurewebsites.net/educations");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task PutEducation()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/education/{_education.Id}", _education);
                if (response.IsSuccessStatusCode)
                {
                    _education = new Education();
                    EducationList = await httpClient.GetFromJsonAsync<List<Education>>("https://webblabb3api.azurewebsites.net/educations");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteEducation()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/education/{_education.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _education = new Education();
                    EducationList = await httpClient.GetFromJsonAsync<List<Education>>("https://webblabb3api.azurewebsites.net/educations");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Education CRUD
        private async Task OnExperienceSelected(ChangeEventArgs experience)
        {
            var selectedExperience = experience.Value.ToString();
            if (int.TryParse(selectedExperience, out int selectedExperienceId))
            {
                _experience = ExperienceList.FirstOrDefault(a => a.Id == selectedExperienceId);
                if (_experience != null)
                {
                    Console.WriteLine($"Selected skill ID: {_experience.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }
        }

        //C
        private async Task PostExperience()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/experience", _experience);
                if (response.IsSuccessStatusCode)
                {
                    _experience = new Experience();
                    ExperienceList = await httpClient.GetFromJsonAsync<List<Experience>>("https://webblabb3api.azurewebsites.net/experiences");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task PutExperience()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/experience/{_experience.Id}", _experience);
                if (response.IsSuccessStatusCode)
                {
                    _experience = new Experience();
                    ExperienceList = await httpClient.GetFromJsonAsync<List<Experience>>("https://webblabb3api.azurewebsites.net/experiences");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteExperience()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/experience/{_experience.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _experience = new Experience();
                    ExperienceList = await httpClient.GetFromJsonAsync<List<Experience>>("https://webblabb3api.azurewebsites.net/experiences/");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Contact CRUD
        private async Task OnContactSelected(ChangeEventArgs contact)
        {
            var selectedContact = contact.Value.ToString();
            if (int.TryParse(selectedContact, out int selectedContactId))
            {
                _contact = ContactList.FirstOrDefault(a => a.Id == selectedContactId);
                if (_contact != null)
                {
                    Console.WriteLine($"Selected skill ID: {_contact.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }
        }

        //C
        private async Task PostContact()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/contact", _contact);
                if (response.IsSuccessStatusCode)
                {
                    _contact = new Contact();
                    ContactList = await httpClient.GetFromJsonAsync<List<Contact>>("https://webblabb3api.azurewebsites.net/contacts");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task PutContact()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/contact/{_contact.Id}", _contact.Id);
                if (response.IsSuccessStatusCode)
                {
                    _contact = new Contact();
                    ContactList = await httpClient.GetFromJsonAsync<List<Contact>>("https://webblabb3api.azurewebsites.net/contacts");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteContact()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/contact/{_contact.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _contact = new Contact();
                    ContactList = await httpClient.GetFromJsonAsync<List<Contact>>("https://webblabb3api.azurewebsites.net/contacts");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Contact CRUD
        private async Task OnCourseSelected(ChangeEventArgs course)
        {
            var selectedCourse = course.Value.ToString();
            if (int.TryParse(selectedCourse, out int selectedCourseId))
            {
                _courses = CourseList.FirstOrDefault(a => a.Id == selectedCourseId);
                if (_courses != null)
                {
                    Console.WriteLine($"Selected skill ID: {_courses.Id}");

                }
                else
                {
                    Console.WriteLine("Invalid skill ID");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for skill ID");
            }
        }

        //C
        private async Task PostCourse()
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"https://webblabb3api.azurewebsites.net/course", _courses);
                if (response.IsSuccessStatusCode)
                {
                    _courses = new Courses();
                    CourseList = await httpClient.GetFromJsonAsync<List<Courses>>("https://webblabb3api.azurewebsites.net/courses");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //U
        private async Task PutCourse()
        {
            try
            {
                var response = await httpClient.PutAsJsonAsync($"https://webblabb3api.azurewebsites.net/course/{_courses.Id}", _courses.Id);
                if (response.IsSuccessStatusCode)
                {
                    _courses = new Courses();
                    CourseList = await httpClient.GetFromJsonAsync<List<Courses>>("https://webblabb3api.azurewebsites.net/courses");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //D
        private async Task DeleteCourse()
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://webblabb3api.azurewebsites.net/course/{_courses.Id}");
                if (response.IsSuccessStatusCode)
                {
                    _courses = new Courses();
                    CourseList = await httpClient.GetFromJsonAsync<List<Courses>>("https://webblabb3api.azurewebsites.net/courses");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
