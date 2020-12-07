// ReSharper disable InconsistentNaming
namespace DbModel
{
   public enum StatusMapEnum
    {
        Not_set,
        Positions,
        StaticDate,
        Trade,
        ModelRun,
        StrategyPosition
    }
    public enum StatusMapCodesEnum
    {
        Ready_to_add,
        Authorised,
        Deleted,
        Ready_to_submit_edit,
        Ready_to_authorise_edit,
        Abort_edit,
        Ready_to_submit_delete,
        Ready_to_authorise_delete,
        Aborted_delete,
        Ready_to_submit_add,
        Ready_to_authorise_add,
        Aborted_add,
        Ready_to_calculate,
        Ready_to_release,
        Released,
        Ready_to_save,
        Ready_to_save_AC3,
        Ready_to_submit,
        Ready_to_submit_AC3,
        Ready_to_authorise_AC3,
        Ready_to_authorise,
        Ready_to_edit,
        Ready_to_save_add
    }
}