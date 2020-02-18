using CDP.Core.Training;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Training
{
    public interface ITraining
    {
        TrainingCategory GetSingleTrainingCategory(int Id);
        TrainingMaster GetSingleTrainingMaster(int Id);
        UserTraining GetSingleUserTraining(int Id);
        List<TrainingCategory> GetTrainingCategotyList();
        List<TrainingMaster> GetTrainingMasterList();
        List<UserTraining> GetUserTrainingList(int UserId);
        int InsertTrainingCategory(TrainingCategory trainingcategorymodel);
        int InsertTrainingMaster(TrainingMaster trainingmastermodel);
        int DeleteTrainingCategory(int Id);
        int DeleteTrainingMaster(int Id);
        int DeleteUserTraining(int Id);
        int UpdateTrainingCategory(TrainingCategory trainingcategorymodel);
        int UpdateTrainingMaster(TrainingMaster trainingmastermodel);
        int InsertUserTraining(UserTraining UserTraining);
        List<TrainingMaster> GetUserTrainingNotMappedList(int UserId);
        int UpdateUserTraining(UserTraining UserTraining);
        List<TrainingMaster> GetUniqueUserTrainingList();
    }
}
