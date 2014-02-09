﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System.IO;
using System.Net.Sockets;

namespace Microsoft.NodejsTools.Debugger.Communication {
    sealed class TcpClientWrapper : ITcpClient {
        private readonly TcpClient _tcpClient;

        public TcpClientWrapper(string hostName, int portNumber) {
            _tcpClient = new TcpClient(hostName, portNumber);
        }

        public bool Connected {
            get { return _tcpClient.Connected; }
        }

        public void Close() {
            _tcpClient.Close();
        }

        public Stream GetStream() {
            return _tcpClient.GetStream();
        }
    }
}