using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace MetricsAgent.DAL
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<CpuMetric, CpuMetricDto>().ForMember(dest => dest.Time,
                source => source.MapFrom(source => DateTimeOffset.FromUnixTimeSeconds(source.Time)));

            CreateMap<DotNetMetric, DotNetMetricDto>().ForMember(dest => dest.Time,
                source => source.MapFrom(source => DateTimeOffset.FromUnixTimeSeconds(source.Time)));

            CreateMap<HddMetric, HddMetricDto>().ForMember(dest => dest.Time,
                source => source.MapFrom(source => DateTimeOffset.FromUnixTimeSeconds(source.Time)));

            CreateMap<NetworkMetric, NetworkMetricDto>().ForMember(dest => dest.Time,
                source => source.MapFrom(source => DateTimeOffset.FromUnixTimeSeconds(source.Time)));

            CreateMap<RamMetric, RamMetricDto>().ForMember(dest => dest.Time,
                source => source.MapFrom(source => DateTimeOffset.FromUnixTimeSeconds(source.Time)));


        }
        
    }
}
