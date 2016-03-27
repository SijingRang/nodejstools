﻿//*********************************************************//
//    Copyright (c) Microsoft. All rights reserved.
//    
//    Apache 2.0 License
//    
//    You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//    
//    Unless required by applicable law or agreed to in writing, software 
//    distributed under the License is distributed on an "AS IS" BASIS, 
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or 
//    implied. See the License for the specific language governing 
//    permissions and limitations under the License.
//
//*********************************************************//

using System;

namespace Microsoft.NodejsTools.Interpreter {
#if FALSE
    /// <summary>
    /// The data passed in the <see cref="PythonTypeDatabase.DatabaseReplaced"/>
    /// event.
    /// </summary>
    public class DatabaseReplacedEventArgs : EventArgs {
        readonly PythonTypeDatabase _newDatabase;

        public DatabaseReplacedEventArgs(PythonTypeDatabase newDatabase) {
            _newDatabase = newDatabase;
        }

        /// <summary>
        /// The updated database.
        /// </summary>
        public PythonTypeDatabase NewDatabase {
            get {
                return _newDatabase;
            }
        }
    }
#endif
}