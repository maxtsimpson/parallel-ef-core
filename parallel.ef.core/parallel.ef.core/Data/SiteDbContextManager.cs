using Microsoft.EntityFrameworkCore;
using System;

public class SiteDbContextManager : ISiteDbContextManager
{
    // Implement interface members here
    public DbContext SiteContext => throw new NotImplementedException();

    public Dictionary<string, IDbContextFactory<DbContext>> SiteDbContextFactoryDictionary => throw new NotImplementedException();

    public void ClearSiteDbContext()
    {
        throw new NotImplementedException();
    }

    public void SetSiteDbContext(FacilityCode facilityCode)
    {
        throw new NotImplementedException();
    }
}