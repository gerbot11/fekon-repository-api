using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IFileMonitoringService
    {
        FileMonitoringHist CreateFileMonitoringH(int totalFile, int totalsize);
        public FileMonitoringResult RunMonitoring(FileDetail file, FileMonitoringHist mh);
        IQueryable<FileMonitoringHist> GetMonitoringHistsForPaging(DateTime? dtfrom, DateTime? dtto);
        Task UpdateFileMonitoringHist(FileMonitoringHist monitoringHist);
        IEnumerable<FileDetail> GetFileDetailsForMonitoring();
        bool ValidateLastRun(DateTime dt, int nextRunMax);
        IQueryable<FileMonitoringResult> GetFileMonitoringResults(long fileMonitoringId);
        List<FileMonitoringResult> GetMonitoringResultByFileDetailId(long fileDetailId);
        FileMonitoringHist GetFileMonitoringHistObjById(long id);
    }
}
