using CDP.Core.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Service.Skills
{
    public interface ISkill
    {
        SkillType GetSkillType(int Id);
        Skill GetSkill(int Id);
        List<SkillType> GetSkillTypeList();
        List<Skill> GetSkillList();
        List<UserSkill> GetUserSkillList(int UserId);
        int InsertSkillType(SkillType skilltypemodel);
        int InsertSkill(Skill skillmodel);
        int DeleteSkillType(int Id);
        int DeleteSkill(int Id);
        int UpdateSkillType(SkillType skilltypemodel);
        int UpdateSkill(Skill skillmodel);
        int InsertUserSkill(UserSkill UserSkill);
        List<Skill> GetUserSkillNotMappedList(int UserId);
        int UpdateUserSkill(UserSkill UserSkill);
    }
}
