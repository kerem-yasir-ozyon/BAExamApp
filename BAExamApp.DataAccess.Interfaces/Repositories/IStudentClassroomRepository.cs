﻿namespace BAExamApp.DataAccess.Interfaces.Repositories;

public interface IStudentClassroomRepository : IAsyncRepository, IAsyncInsertableRepository<StudentClassroom>, IAsyncFindableRepository<StudentClassroom>, IAsyncDeleteableRepository<StudentClassroom>, IAsyncUpdateableRepository<StudentClassroom>, IAsyncTransactionRepository
{
    Task<List<StudentClassroom>> GetActiveStudentsByClassroomIdAsync(Guid classroomId);
}
