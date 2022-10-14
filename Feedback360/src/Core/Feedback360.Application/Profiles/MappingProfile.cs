using AutoMapper;
using Feedback360.Application.Features.Categories.Commands.CreateCategory;
using Feedback360.Application.Features.Categories.Commands.StoredProcedure;
using Feedback360.Application.Features.Categories.Queries.GetCategoriesList;
using Feedback360.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using Feedback360.Application.Features.Events.Commands.CreateEvent;
using Feedback360.Application.Features.Events.Commands.Transaction;
using Feedback360.Application.Features.Events.Commands.UpdateEvent;
using Feedback360.Application.Features.Events.Queries.GetEventDetail;
using Feedback360.Application.Features.Events.Queries.GetEventsExport;
using Feedback360.Application.Features.Events.Queries.GetEventsList;
using Feedback360.Application.Features.Orders.GetOrdersForMonth;
using Feedback360.Domain.Entities;

namespace Feedback360.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
