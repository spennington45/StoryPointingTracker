using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PQCStoryPointing.Shared.Models;

namespace PQCStoryPointing.Shared.Helpers
{
    public static class TestDataHelper
    {
        public static List<OverallUserStats> GetTestData()
        {
            return new List<OverallUserStats>
            {
                new OverallUserStats
                {
                    OverallUserStatsId = 1,
                    UserId = 1,
                    UserName = "Steven",
                    SessionStats = new List<StoryPointSessionStats>
                    {
                        new StoryPointSessionStats
                        {
                            StoryPointSessionStatsId = 1,
                            SessionDTM = DateTime.Now,
                            Data = new List<StoryPointData>
                            {
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now,
                                    StoryId = 12345,
                                    Estimated = 3,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now,
                                    StoryId = 12345,
                                    Estimated = 2,
                                    Actual = 2
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now,
                                    StoryId = 12345,
                                    Estimated = 2,
                                    Actual = 1
                                }
                            }
                        },
                        new StoryPointSessionStats
                        {
                            StoryPointSessionStatsId = 1,
                            SessionDTM = DateTime.Now.AddDays(-7),
                            Data = new List<StoryPointData>
                            {
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-7),
                                    StoryId = 12345,
                                    Estimated = 3,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-7),
                                    StoryId = 12345,
                                    Estimated = 5,
                                    Actual = 5
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-7),
                                    StoryId = 12345,
                                    Estimated = 0.5,
                                    Actual = 1
                                }
                            }
                        },
                        new StoryPointSessionStats
                        {
                            StoryPointSessionStatsId = 1,
                            SessionDTM = DateTime.Now.AddDays(-14),
                            Data = new List<StoryPointData>
                            {
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-14),
                                    StoryId = 12345,
                                    Estimated = 5,
                                    Actual = 5
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-14),
                                    StoryId = 12345,
                                    Estimated = 5,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-14),
                                    StoryId = 12345,
                                    Estimated = 2,
                                    Actual = 1
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-14),
                                    StoryId = 12345,
                                    Estimated = 3,
                                    Actual = 3
                                }
                            }
                        },
                        new StoryPointSessionStats
                        {
                            StoryPointSessionStatsId = 1,
                            SessionDTM = DateTime.Now.AddDays(-21),
                            Data = new List<StoryPointData>
                            {
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-21),
                                    StoryId = 12345,
                                    Estimated = 3,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-21),
                                    StoryId = 12345,
                                    Estimated = 5,
                                    Actual = 5
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-21),
                                    StoryId = 12345,
                                    Estimated = 0.5,
                                    Actual = 1
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-21),
                                    StoryId = 12345,
                                    Estimated = 0.5,
                                    Actual = 0.5
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-21),
                                    StoryId = 12345,
                                    Estimated = 1,
                                    Actual = 1
                                }
                            }
                        }
                    },
                },
                new OverallUserStats
                {
                    OverallUserStatsId = 2,
                    UserId = 1,
                    UserName = "Nick",
                    SessionStats = new List<StoryPointSessionStats>
                    {
                        new StoryPointSessionStats
                        {
                            StoryPointSessionStatsId = 1,
                            SessionDTM = DateTime.Now,
                            Data = new List<StoryPointData>
                            {
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now,
                                    StoryId = 12345,
                                    Estimated = 2,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now,
                                    StoryId = 12345,
                                    Estimated = 2,
                                    Actual = 2
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now,
                                    StoryId = 12345,
                                    Estimated = 0.5,
                                    Actual = 1
                                }
                            }
                        },
                        new StoryPointSessionStats
                        {
                            StoryPointSessionStatsId = 1,
                            SessionDTM = DateTime.Now.AddDays(-7),
                            Data = new List<StoryPointData>
                            {
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-7),
                                    StoryId = 12345,
                                    Estimated = 3,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-7),
                                    StoryId = 12345,
                                    Estimated = 5,
                                    Actual = 3
                                },
                                new StoryPointData
                                {
                                    StoryPointDataId = 1,
                                    Date = DateTime.Now.AddDays(-7),
                                    StoryId = 12345,
                                    Estimated = 0.5,
                                    Actual = 0.5
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
