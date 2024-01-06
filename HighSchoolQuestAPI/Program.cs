using ApplicationContext;
using BlueShopAPI.Middlewares;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Mapper;
using BusinessLogicLayer.Service;
using BusinessLogicLayer.Util;
using DataAccessLayer.UnitOfWork;
using Domain.Global;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



var configuration = builder.Configuration.Get<AppSettings>();
builder.Services.AddDbContext<HighSchoolQuestContext>(options =>
options.UseNpgsql(configuration!.ConnectionStrings.DefaultConnection));
builder.Services.AddSwaggerGen
    (
    opt =>
    {
        opt.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
        {
            Description = "Standard Authorization (\"bearer {token}\" ) ",
            In = ParameterLocation.Header,
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey
        });
        opt.OperationFilter<SecurityRequirementsOperationFilter>();

    }

    );
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration!.SecretToken.Value)),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    });

builder.Services.AddAutoMapper(typeof(MapperConfigurationsProfile).Assembly);

builder.Services.AddSingleton(configuration);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddTransient<GlobalMiddleware>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISubjectService, SubjectService>();
builder.Services.AddScoped<ITopicService, TopicService>();
builder.Services.AddScoped<IUniversityService, UniversityService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IExaminationService, ExaminationService>();
builder.Services.AddScoped<IExaminationQuestionService, ExaminationQuestionService>();
builder.Services.AddScoped<IAttemptService, AttemptService>();
builder.Services.AddScoped<IMajorService, MajorService>();
builder.Services.AddScoped<IAttemptDetailService, AttemptDetailService>();
builder.Services.AddScoped<IMBTIService, MBTIService>();
builder.Services.AddScoped<IClaimsService, ClaimsService>();
builder.Services.AddScoped<IMBTI_QuestionService, MBTI_QuestionService>();
builder.Services.AddScoped<IMBTI_ExamService, MBTI_ExamService>();
builder.Services.AddScoped<IMBTI_UserRecordService, MBTI_UserRecordService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IMomoService, MomoService>();
builder.Services.AddScoped<IStudentPurchasedService, StudentPurchasedService>();
builder.Services.AddHttpContextAccessor();



var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseMiddleware<PostgresExceptionMiddleware>();
//app.UseMiddleware<GlobalMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    //serviceScope.ServiceProvider.GetService<HighSchoolQuestContext>().Database.Migrate();
}

app.Run();
