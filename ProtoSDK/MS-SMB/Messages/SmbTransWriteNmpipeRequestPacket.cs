// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

using Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Cifs;

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Smb
{
    /// <summary>
    /// Packets for SmbTransWriteNmpipe Request 
    /// </summary>
    public class SmbTransWriteNmpipeRequestPacket : Cifs.SmbTransWriteNmpipeRequestPacket
    {
        #region Fields

        /// <summary>
        /// the SMB_Parameters 
        /// </summary>
        protected new SMB_COM_TRANSACTION_Request_SMB_Parameters_File smbParameters;

        #endregion

        #region Properties

        /// <summary>
        /// get or set the Smb_Parameters:SMB_COM_TRANSACTION_Request_SMB_Parameters 
        /// </summary>
        public override SMB_COM_TRANSACTION_Request_SMB_Parameters SmbParameters
        {
            get
            {
                return SmbMessageUtils.ConvertTransactionFilePacketPayload(this.smbParameters);
            }
            set
            {
                this.smbParameters = SmbMessageUtils.ConvertTransactionFilePacketPayload(value);
                base.smbParameters = value;
            }
        }


        #endregion
        
        #region Convert from base class

        /// <summary>
        /// initialize packet from base packet. 
        /// </summary>
        /// <param name = "packet">the base packet to initialize this packet. </param>
        public SmbTransWriteNmpipeRequestPacket(Cifs.SmbTransWriteNmpipeRequestPacket packet)
            : base(packet)
        {
            this.smbParameters = SmbMessageUtils.ConvertTransactionFilePacketPayload(packet.SmbParameters);
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Constructor. 
        /// </summary>
        public SmbTransWriteNmpipeRequestPacket()
            : base()
        {
        }


        /// <summary>
        /// Constructor: Create a request directly from a buffer. 
        /// </summary>
        public SmbTransWriteNmpipeRequestPacket(byte[] data)
            : base(data)
        {
        }


        /// <summary>
        /// Deep copy constructor. 
        /// </summary>
        public SmbTransWriteNmpipeRequestPacket(SmbTransWriteNmpipeRequestPacket packet)
            : base(packet)
        {
        }


        #endregion
    }
}
