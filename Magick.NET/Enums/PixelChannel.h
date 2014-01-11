//=================================================================================================
// Copyright 2013-2014 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
#pragma once

#include "Stdafx.h"

namespace ImageMagick
{
	///=============================================================================================
	///<summary>
	/// Specifies the pixel channels.
	///</summary>
	public enum class PixelChannel
	{
		Undefined = Magick::UndefinedChannel,
		Red = Magick::RedChannel,
		Cyan = Magick::CyanChannel,
		Gray = Magick::GrayChannel,
		Green = Magick::GreenChannel,
		Magenta = Magick::MagentaChannel,
		Blue = Magick::BlueChannel,
		Yellow = Magick::YellowChannel,
		Black = Magick::BlackChannel,
		Alpha = Magick::AlphaChannel,
		Index = Magick::IndexChannel,
		Composite = Magick::CompositeChannels
	};
	//==============================================================================================
}