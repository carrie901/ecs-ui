// ----------------------------------------------------------------------------
// The MIT License
// Ui extension https://github.com/Leopotam/ecs-ui
// for ECS framework https://github.com/Leopotam/ecs
// Copyright (c) 2018 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;

namespace LeopotamGroup.Ecs.Ui.Components {
    public sealed class EcsUiEnterEvent {
        public string WidgetName;

        public int PointerId;

        public GameObject Sender;
    }
}