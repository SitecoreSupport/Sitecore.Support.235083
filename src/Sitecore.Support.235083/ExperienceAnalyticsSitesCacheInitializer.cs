using Sitecore.Caching;
using Sitecore.Caching.Generics;

namespace Sitecore.Support
{
  public static class ExperienceAnalyticsSitesCacheInitializer
  {
    private static ICache<string> _cache;

    public static void Initialize()
    {
      //create a strong reference for the ExperienceAnalytics.Sites cache.
      _cache = CacheManager.FindCacheByName<string>("ExperienceAnalytics.Sites") ?? new Cache<string>("ExperienceAnalytics.Sites", 1048576);
    }
  }
}