using Microsoft.EntityFrameworkCore;
using WebbLabb3.UI.Data;
using WebbLabb3.UI.Models;


var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;
var connectionString = Environment.GetEnvironmentVariable("Labb3");
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        connectionString));


var app = builder.Build();

var config = new ConfigurationBuilder()
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("api_appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"api_appsettings.{env.EnvironmentName}.json", optional: true)
    .Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// CRUD About

//Read

app.MapGet("/Abouts", async (ApplicationDbContext context) =>
{
    return await context.About.ToListAsync();
});



app.MapGet("/About/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.About.FindAsync(id) is About about ?
    Results.Ok(about) :
    Results.NotFound("Does not exist");
});

//Create

app.MapPost("/About", async (ApplicationDbContext context, About about) =>
{
    context.About.Add(about);
    await context.SaveChangesAsync();
    return Results.Ok(await context.About.ToListAsync());

});

//Update

app.MapPut("/About/{id}", async (ApplicationDbContext context, About updateAbouts, int id) =>
{
    var about = await context.About.FindAsync(id);

    if (about == null)
    {
        return Results.NotFound("Sorry, this info doesnt exists");


    }

    about.FirstName = updateAbouts.FirstName;
    about.LastName = updateAbouts.LastName;
    about.Description = updateAbouts.Description;

    await context.SaveChangesAsync();

    return Results.Ok(await context.About.ToListAsync());
});

//Delete

app.MapDelete("/About/{id}", async (ApplicationDbContext context, int id) =>
{
    var abouts = await context.About.FindAsync(id);

    if (abouts == null)
    {
        return Results.NotFound("Sorry, this info doesnt exists");
    }






    context.About.Remove(abouts);
    await context.SaveChangesAsync();

    return Results.Ok(await context.About.ToListAsync());
});

//CRUD Contact

//R

app.MapGet("/contacts", async (ApplicationDbContext context) =>
{
    return await context.Contact.ToListAsync();
});

app.MapGet("/contact/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.Contact.FindAsync(id) is Contact contact ?
    Results.Ok(contact) :
    Results.NotFound("Does not exist");
});

//U

app.MapPost("/contact", async (ApplicationDbContext context, Contact contact) =>
{
    context.Contact.Add(contact);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Contact.ToListAsync());
});

//C

app.MapPut("/contact/{id}", async (ApplicationDbContext context, Contact updateContact, int id) =>
{
    var contact = await context.Contact.FindAsync(id);

    if (contact == null)
    {
        return Results.NotFound("Sorry, no contact found");
    }

    contact.PhoneNumber = updateContact.PhoneNumber;
    contact.Email = updateContact.Email;
    contact.LinkedInUrl = updateContact.LinkedInUrl;

    await context.SaveChangesAsync();

    return Results.Ok(await context.Contact.ToListAsync());

});

//D
app.MapDelete("/contact/{id}", async (ApplicationDbContext context, int id) =>
{
    var contact = await context.Contact.FindAsync(id);

    if (contact == null)
    {
        return Results.NotFound("Sorry, this contact doesnt exists");
    }






    context.Contact.Remove(contact);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Contact.ToListAsync());
});

//CRUD Education

//R

app.MapGet("/educations", async (ApplicationDbContext context) =>
{
    return await context.Education.ToListAsync();
});

app.MapGet("/education/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.Education.FindAsync(id) is Education education ?
    Results.Ok(education) :
    Results.NotFound("Does not exist");
});

//U

app.MapPost("/education", async (ApplicationDbContext context, Education education) =>
{
    context.Education.Add(education);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Education.ToListAsync());
});

//C

app.MapPut("/education/{id}", async (ApplicationDbContext context, Education updateEducation, int id) =>
{
    var education = await context.Education.FindAsync(id);

    if (education == null)
    {
        return Results.NotFound("Sorry, no education found");
    }

    education.SchoolName = updateEducation.SchoolName;

    education.Year = updateEducation.Year;
    education.Title = updateEducation.Title;

    await context.SaveChangesAsync();

    return Results.Ok(await context.Education.ToListAsync());

});

//D
app.MapDelete("/education/{id}", async (ApplicationDbContext context, int id) =>
{
    var education = await context.Education.FindAsync(id);

    if (education == null)
    {
        return Results.NotFound("Sorry, this education doesnt exists");
    }






    context.Education.Remove(education);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Education.ToListAsync());
});

//CRUD Projects

//R

app.MapGet("/projects", async (ApplicationDbContext context) =>
{
    return await context.Projects.ToListAsync();
});

app.MapGet("/project/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.Projects.FindAsync(id) is Projects project ?
    Results.Ok(project) :
    Results.NotFound("Does not exist");
});

//U

app.MapPost("/project", async (ApplicationDbContext context, Projects project) =>
{
    context.Projects.Add(project);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Projects.ToListAsync());
});

//C

app.MapPut("/project/{id}", async (ApplicationDbContext context, Projects updateProject, int id) =>
{
    var project = await context.Projects.FindAsync(id);

    if (project == null)
    {
        return Results.NotFound("Sorry, no project found");
    }

    project.GithubUrl = updateProject.GithubUrl;


    await context.SaveChangesAsync();

    return Results.Ok(await context.Projects.ToListAsync());

});

//D
app.MapDelete("/project/{id}", async (ApplicationDbContext context, int id) =>
{
    var project = await context.Projects.FindAsync(id);

    if (project == null)
    {
        return Results.NotFound("Sorry, this project doesnt exists");
    }






    context.Projects.Remove(project);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Projects.ToListAsync());
});

//CRUD Skills

//R

app.MapGet("/skills", async (ApplicationDbContext context) =>
{
    return await context.Skills.ToListAsync();
});

app.MapGet("/skill/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.Skills.FindAsync(id) is Skills skill ?
    Results.Ok(skill) :
    Results.NotFound("Does not exist");
});

//C

app.MapPost("/skill", async (ApplicationDbContext context, Skills skill) =>
{
    context.Skills.Add(skill);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Skills.ToListAsync());
});

//U

app.MapPut("/skill/{id}", async (ApplicationDbContext context, Skills updateskill, int id) =>
{
    var skill = await context.Skills.FindAsync(id);

    if (skill == null)
    {
        return Results.NotFound("Sorry, no contact found");
    }

    skill.SkillName = updateskill.SkillName;
    skill.Description = updateskill.Description;

    await context.SaveChangesAsync();

    return Results.Ok(await context.Skills.ToListAsync());

});

//D
app.MapDelete("/skill/{id}", async (ApplicationDbContext context, int id) =>
{
    var skill = await context.Skills.FindAsync(id);

    if (skill == null)
    {
        return Results.NotFound("Sorry, this skill doesnt exists");
    }






    context.Skills.Remove(skill);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Skills.ToListAsync());
});

//CRUD WorkExperience

//R

app.MapGet("/experiences", async (ApplicationDbContext context) =>
{
    return await context.Experience.ToListAsync();
});

app.MapGet("/experience/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.Experience.FindAsync(id) is Experience workXp ?
    Results.Ok(workXp) :
    Results.NotFound("Does not exist");
});

//U

app.MapPost("/experience", async (ApplicationDbContext context, Experience workXp) =>
{
    context.Experience.Add(workXp);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Experience.ToListAsync());
});

//C

app.MapPut("/experience/{id}", async (ApplicationDbContext context, Experience updateWorkXp, int id) =>
{
    var workXp = await context.Experience.FindAsync(id);

    if (workXp == null)
    {
        return Results.NotFound("Sorry, no experience found");
    }

    workXp.CompanyName = updateWorkXp.CompanyName;
    workXp.Description = updateWorkXp.Description;
    workXp.Year = updateWorkXp.Year;
    workXp.Title = updateWorkXp.Title;

    await context.SaveChangesAsync();

    return Results.Ok(await context.Experience.ToListAsync());

});

//D
app.MapDelete("/experience/{id}", async (ApplicationDbContext context, int id) =>
{
    var workXp = await context.Experience.FindAsync(id);

    if (workXp == null)
    {
        return Results.NotFound("Sorry, this experience doesnt exists");
    }






    context.Experience.Remove(workXp);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Experience.ToListAsync());
});

//Courses

//R

app.MapGet("/courses", async (ApplicationDbContext context) =>
{
    return await context.Courses.ToListAsync();
});

app.MapGet("/course/{id}", async (ApplicationDbContext context, int id) =>
{
    return await context.Courses.FindAsync(id) is Courses courses ?
    Results.Ok(courses) :
    Results.NotFound("Does not exist");
});

//U

app.MapPost("/course", async (ApplicationDbContext context, Courses course) =>
{
    context.Courses.Add(course);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Courses.ToListAsync());
});

//C

app.MapPut("/course/{id}", async (ApplicationDbContext context, Courses updateCourse, int id) =>
{
    var course = await context.Courses.FindAsync(id);

    if (course == null)
    {
        return Results.NotFound("Sorry, no course found");
    }

    course.CourseName = updateCourse.CourseName;


    await context.SaveChangesAsync();

    return Results.Ok(await context.Courses.ToListAsync());

});

//D
app.MapDelete("/Course/{id}", async (ApplicationDbContext context, int id) =>
{
    var course = await context.Courses.FindAsync(id);

    if (course == null)
    {
        return Results.NotFound("Sorry, this experience doesnt exists");
    }






    context.Courses.Remove(course);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Courses.ToListAsync());
});

app.Run();


