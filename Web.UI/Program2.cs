//using Autofac.Core;
//using Common;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System.Text.Encodings.Web;
//using System.Text.Unicode;

//var builder = WebApplication.CreateBuilder(args);

//#region Services

////services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));

////services.InitializeAutoMapper();

////services.AddDbContext(Configuration);
////services.AddCustomIdentity(_siteSetting.IdentitySettings);
////services.AddMinimalMvc();
////services.AddElmahCore(Configuration, _siteSetting);
////services.AddJwtAuthentication(_siteSetting.JwtSettings);

////services.AddCustomApiVersioning();

////services.AddSwagger();








//// Add services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddAutoMapper(typeof(Program));

//// ارتقای حجم آپلود فایل در وب سرور کسترل
//builder.WebHost.ConfigureKestrel((context, options) =>
//{
//    // Handle requests up to 100 MB
//    options.Limits.MaxRequestBodySize = 104857600;
//});

//#region Database Context

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
//});

//#endregion

//#region IoC

//builder.Services.AddScoped<IUploadFiles, UploadFiles>();
//builder.Services.AddScoped<IGenerateFolders, GenerateFolders>();
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//#endregion

//#region Encode For Js

//builder.Services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

//#endregion

//#region Authentication

//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//}).AddCookie(options =>
//{
//    options.LoginPath = "/Login";
//    options.LogoutPath = "/Logout";
//    options.Cookie.Name = "Sabtenam";
//    options.ExpireTimeSpan = TimeSpan.FromDays(1);
//});

//#endregion

//#endregion

//#region MiddleWares

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
////app.UseStaticFiles();

//app.UseWhen(
//    context => !context.Request.Path.StartsWithSegments("/applicantFiles"),
//    appBuilder => appBuilder.UseStaticFiles());

//app.UseRouting();

//app.UseAuthentication();
//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");



//app.Run();

//#endregion
