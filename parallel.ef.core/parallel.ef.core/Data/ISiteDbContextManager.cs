
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public interface ISiteDbContextManager
{
    DbContext SiteContext { get; }
    Dictionary<string, IDbContextFactory<DbContext>> SiteDbContextFactoryDictionary { get; }
    void SetSiteDbContext(FacilityCode facilityCode);
    void ClearSiteDbContext();
}
