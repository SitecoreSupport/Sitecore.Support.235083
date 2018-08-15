using Sitecore.Pipelines;

namespace Sitecore.Support
{
  public class InitializeExperienceAnalyticsSitesCache
  {
    public void Process(PipelineArgs args)
    {
      ExperienceAnalyticsSitesCacheInitializer.Initialize();
    }
  }
}