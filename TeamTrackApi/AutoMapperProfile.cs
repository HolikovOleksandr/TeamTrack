namespace TeamTrackApi;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Employee, GetEmployeeDto>();
        CreateMap<AddEmployeeDto, Employee>();
        CreateMap<UpdateEmployeeDto, Employee>();
    }
}