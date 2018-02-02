using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEXCORE.Utility.GlobalVariable
{
    public class FileInformation
    {
        /// <summary>
        /// 파일 FullPath
        /// </summary>
        public string _fileFullName { get; set; }
        /// <summary>
        /// 프로그램코드
        /// </summary>
        public string _programCode { get; set; }
        /// <summary>
        /// 파일명
        /// </summary>
        public string _filename { get; set; }
        /// <summary>
        /// 생성일시
        /// </summary>
        public DateTime _createTime { get; set; }
        /// <summary>
        /// 최종수정일
        /// </summary>
        public DateTime _lastAccessTime { get; set; }
        /// <summary>
        /// 전송일
        /// </summary>
        public string _sendTime { get; set; }
        /// <summary>
        /// 파일크기
        /// </summary>
        public long _fileSize { get; set; }
        /// <summary>
        /// 파일확장자
        /// </summary>
        public string _Extension { get; set; }
        /// <summary>
        /// 파일속성:읽기전용YN
        /// </summary>
        public bool _ReadOnly { get; set; }
    }
}
