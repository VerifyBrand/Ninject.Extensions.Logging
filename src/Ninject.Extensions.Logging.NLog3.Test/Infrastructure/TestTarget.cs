//-------------------------------------------------------------------------------
// <copyright file="TestTarget.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 Software Services AG
//   Remo Gloor (remo.gloor@gmail.com)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.Extensions.Logging.NLog3.Infrastructure
{
    using global::NLog;
    using NLog.Targets;

    /// <summary>
    /// A log target that provides the last log event.
    /// </summary>
    public class TestTarget : TargetWithLayout
    {
        /// <summary>
        /// Gets the last log event.
        /// </summary>
        /// <value>The last log event.</value>
        public LogEventInfo LastLogEvent { get; private set; }

        /// <summary>
        /// Gets the last message.
        /// </summary>
        /// <value>The last message.</value>
        public string LastMessage { get; private set; }

        /// <summary>
        /// Writes logging event to the log target. Must be overridden in inheriting
        /// classes.
        /// </summary>
        /// <param name="logEvent">Logging event to be written out.</param>
        protected override void Write(LogEventInfo logEvent)
        {
            this.LastLogEvent = logEvent;
            this.LastMessage = this.Layout.Render(logEvent);
        }
    }
}