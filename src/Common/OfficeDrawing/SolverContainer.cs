/*
 * Copyright (c) 2008, DIaLOGIKa
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *        notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of DIaLOGIKa nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY DIaLOGIKa ''AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL DIaLOGIKa BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.IO;

namespace DIaLOGIKa.b2xtranslator.OfficeDrawing
{
    [OfficeRecord(0xF005)]
    public class SolverContainer : RegularContainer
    {
        public SolverContainer(BinaryReader _reader, uint size, uint typeCode, uint version, uint instance)
            : base(_reader, size, typeCode, version, instance) {

                foreach (var item in this.Children)
                {
                    switch (item.TypeCode)
                    {
                        default:
                            break;
                    }
                }
        
        }
    }

    [OfficeRecord(0xF012)]
    public class FConnectorRule : Record
    {
        public uint ruid;
        public uint spidA;
        public uint spidB;
        public uint spidC;
        public uint cptiA;
        public uint cptiB;

        public FConnectorRule(BinaryReader _reader, uint size, uint typeCode, uint version, uint instance)
            : base(_reader, size, typeCode, version, instance) {

            this.ruid = this.Reader.ReadUInt32();
            this.spidA = this.Reader.ReadUInt32();
            this.spidB = this.Reader.ReadUInt32();
            this.spidC = this.Reader.ReadUInt32();
            this.cptiA = this.Reader.ReadUInt32();
            this.cptiB = this.Reader.ReadUInt32();
        }
    }

    [OfficeRecord(0xF014)]
    public class FArcRule : Record
    {
        public uint ruid;
        public uint spid;

        public FArcRule(BinaryReader _reader, uint size, uint typeCode, uint version, uint instance)
            : base(_reader, size, typeCode, version, instance) {

            this.ruid = this.Reader.ReadUInt32();
            this.spid = this.Reader.ReadUInt32();
        }
    }

    [OfficeRecord(0xF017)]
    public class FCalloutRule : Record
    {
        public uint ruid;
        public uint spid;

        public FCalloutRule(BinaryReader _reader, uint size, uint typeCode, uint version, uint instance)
            : base(_reader, size, typeCode, version, instance) {

            this.ruid = this.Reader.ReadUInt32();
            this.spid = this.Reader.ReadUInt32();
        }
    }

}
