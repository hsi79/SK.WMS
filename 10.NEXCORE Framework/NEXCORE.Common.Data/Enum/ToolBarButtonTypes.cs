using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEXCORE.Common.Data
{
    public enum ToolBarButtonTypes
    {
#if false
        Clear = 1,//초기화
        Request = 2,//조회
        DeleteAll = 3,//모두 삭제
        Save = 4,//저장
        Insert = 5,//로 삽입
        Delete = 6,//로 삭제
        Cut = 7,//잘라내기
        Copy = 8,//복사
        Paste = 9,//붙여넣기
        Print = 10,//출력
        Excel = 11,//엑셀로 Exporting
        Search = 12,//착지
        Sum = 13,//합계
        DescendingSort = 14,//내림차순 정렬
        AscendingSort = 15,//오름차순
        First = 16,
        Previous = 17,//이전
        Next = 18,//다음
        End = 19,
        None = 20
#else
        Clear = 1,//초기화
        Request = 2,//조회
        DeleteAll = 4,//모두 삭제
        Save = 8,//저장
        Insert = 16,//로 삽입
        Delete = 32,//로 삭제
        Cut = 64,//잘라내기
        Copy = 128,//복사
        Paste = 256,//붙여넣기
        Print = 512,//출력
        Excel = 1024,//엑셀로 Exporting
        Search = 2048,//착지
        Sum = 4096,//합계
        DescendingSort = 8192,//내림차순 정렬
        AscendingSort = 16384,//오름차순
        First = 32768,
        Previous = 65536,//이전
        Next = 131072,//다음
        End = 262144,
        Ship = 524288,
        Account = 1048576,
        Port = 2097152,
        Undo = 4194304,
        None = 8388608,
        All = 16777216
#endif
    }
}
