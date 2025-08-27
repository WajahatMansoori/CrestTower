using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoticeManagementv2.Application.Mapping;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace NoticeManagementv2.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddNoticeServices(this IServiceCollection services, string hrmsMasterConnectionString, string hrmsDbConnectionString)
        {
            
            services.AddAutoMapper(typeof(Profiles));

            return services;
        }
    }
}
