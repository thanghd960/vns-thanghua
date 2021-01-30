using System.Collections.Generic;
using Vns.Core.Commons;

public class ResponseData<TEntity>
{   
    public IPagedList<TEntity> Data { get; set; }
    public ResultStatus Result { get; set; }
}

public class ResultStatus 
{
    public bool Status { get; set; }
    public eMessageCode Code { get; set; }
    public string Message { get; set; }
}